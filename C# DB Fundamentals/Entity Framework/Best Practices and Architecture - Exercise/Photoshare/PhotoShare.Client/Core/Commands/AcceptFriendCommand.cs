﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Contracts;
    using Dtos;
    using Messages;
    using Services.Contracts;

    public class AcceptFriendCommand : ICommand
    {
        private readonly IUserService userService;

        public AcceptFriendCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // AcceptFriend <username1> <username2>
        public string Execute(string[] data)
        {
            string username = data[0];
            string friendUsername = data[1];

            ValidateUserExist(username);
            ValidateUserExist(friendUsername);

            UserFriendsDto user = this.userService.ByUsername<UserFriendsDto>(username);
            UserFriendsDto friend = this.userService.ByUsername<UserFriendsDto>(friendUsername);

            bool isSendRequestFromUser = user.Friends.Any(x => x.Username == friend.Username);
            bool isSendRequestFromFriend = friend.Friends.Any(x => x.Username == user.Username);

            if (isSendRequestFromUser && isSendRequestFromFriend)
                throw new InvalidOperationException(String.Format(ErrorMessages.AlreadyFriends, friend.Username, user.Username));
            else if (!isSendRequestFromFriend)
                throw new InvalidOperationException(String.Format(ErrorMessages.NoFriendRequest, friend.Username, user.Username));

            this.userService.AcceptFriend(user.Id, friend.Id);

            string result = String.Format(ResultMessages.SuccessfullyAcceptedFriend, user.Username, friend.Username);
            return result;
        }

        private void ValidateUserExist(string username)
        {
            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));
        }
    }
}
