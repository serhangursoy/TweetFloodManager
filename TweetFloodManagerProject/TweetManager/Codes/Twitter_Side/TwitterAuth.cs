using System;
using System.Collections.Generic;
using System.Diagnostics;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace TweetManager.Codes.Twitter_Side
{
    class TwitterAuth
    {

        public string ACCESS_TOKEN;
        public string ACCESS_SECRET;
        private string CONSUMER_KEY = "YOURCONSUMERKEY";
        private string CONSUMER_SECRET_KEY = "YOURSECRETKEY";

        IAuthenticationContext authenticationContext;
        public void StartAuthProcess()  {
            // Create a new set of credentials for the application. TODO: Dont get it from here.
            var appCredentials = new TwitterCredentials(CONSUMER_KEY, CONSUMER_SECRET_KEY);

            // Init the authentication process and store the related `AuthenticationContext`.
            authenticationContext = AuthFlow.InitAuthentication(appCredentials);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
            Process.Start(authenticationContext.AuthorizationURL);
        }

        public bool SetAuthWithCredentials(string SECRET, string TOKEN) {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET_KEY, TOKEN, SECRET);

            IAuthenticatedUser authenticatedUser;

            try
            {
                // Get User Auth
                authenticatedUser = User.GetAuthenticatedUser();

                // Is it null? If so, we have a problem.
                if (authenticatedUser == null) // Something went wrong but we don't know what
                {
                    return false;
                }
            }
            catch (Exception e) { return false; }

            return true;
        }
        // This is for setting the auth. Required pin will be given as string input.
        public bool SetAuth(string pinCode)
        {
            // With this pin code it is now possible to get the credentials back from Twitter
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);

            // Use the user credentials in your application
            Tweetinvi.Auth.SetCredentials(userCredentials);

            IAuthenticatedUser authenticatedUser;
            // Check success
            try
            {
                // Get User Auth
                authenticatedUser = User.GetAuthenticatedUser();

                // Is it null? If so, we have a problem.
                if (authenticatedUser == null) // Something went wrong but we don't know what
                {
                    return false;
                }
            }
            catch (Exception e){ return false; }

            // If everything goes smooth, we should set certain things in order to access them later.
            ACCESS_TOKEN  = authenticatedUser.Credentials.AccessToken.ToString();
            ACCESS_SECRET = authenticatedUser.Credentials.AccessTokenSecret.ToString();

            // If its not null and doesnt have any particular expection than we are good to go.
            return true;
        }

        // Get tweet list, start to make your flood.
        public void PostTweets(List<string> userTweets) {
            var authenticatedUser = User.GetAuthenticatedUser();

            // We have to keep last tweet
            var LastTweet = Tweet.PublishTweet(userTweets[0]);
            
            for (int i = 1; i < userTweets.Count; i++)
            {
                var reply = Tweet.PublishTweet(userTweets[i], new PublishTweetOptionalParameters
                {
                    InReplyToTweet = LastTweet
                });

                LastTweet = reply;
            }

        }
    }
}
