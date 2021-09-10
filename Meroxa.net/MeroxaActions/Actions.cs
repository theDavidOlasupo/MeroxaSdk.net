using System;
using Meroxa.net.helpers.Models;

namespace Meroxa.net.helpers.MeroxaActions
{
    public class Actions
    {
        public Actions()
        {
        }
        public static MeroxaResponse meroxaResponse = new MeroxaResponse();// just a fake default response
        /// <summary>
        /// Returns token to user, that will be used to call Meroxa actions
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static MeroxaResponse Login(string username, string password)
        {
            //Generate Meroxa API token

            try
            {

                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Login successful",
                    data = new data
                    {
                        Metadata = "YourSampleToken"
                    }
                };

                return DummyResponse;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return meroxaResponse;
        }

        /// <summary>
        /// Create a resource that wil act as the source of a pipeline, possible sources are SQL, MYSQL, POSTGres, MongoDB 
        /// </summary>
        /// <param name="ResourceType"></param>
        /// <param name="password"></param>
        /// <param name="Token"></param>
        /// <returns></returns>

        public static MeroxaResponse CreateSource(string ResourceType, string password, string Token)
        {
            //call CreateSource list API

            try
            {
                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Resource created successfully",
                    data = new data
                    {
                        Metadata = "resource ID"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return meroxaResponse;

        }


        /// <summary>
        /// Create a resource that wil act as the detinaton of a pipeline, possible sources are API urls, S3 etc
        /// 
        /// </summary>
        /// <param name="ResourceType"></param>
        /// <param name="ResourceUsername"></param>
        /// <param name="ResourcePassword"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static MeroxaResponse CreateDestination(string ResourceType, string ResourceUsername, string ResourcePassword, string Token)
        {
            //call CreateDestination list API
            try
            {
                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Resource created successfully",
                    data = new data
                    {
                        Metadata = "resource ID"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return meroxaResponse;
        }

        /// <summary>
        /// Create resource pipepline
        /// </summary>
        /// <param name="ResourceType"></param>
        /// <param name="ResourceUsername"></param>
        /// <param name="ResourcePassword"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static MeroxaResponse CreatePipeline(string ResourceType, string ResourceUsername, string ResourcePassword, string Token)
        {
            //call CreatePipeline list API
            try
            {
                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Resource created successfully",
                    data = new data
                    {
                        Metadata = "resource ID"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());

            }
            return meroxaResponse;
        }


        /// <summary>
        /// Connect a Source to a destination
        /// </summary>
        /// <param name="Pipeline"></param>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static MeroxaResponse ConnectResources(string Pipeline, string Source, string Destination, string Token)
        {
            //call ConnectResources list API

            try
            {
                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Resources connected successfully",
                    data = new data
                    {
                        Metadata = "Pipeline ID"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception
                Console.Write(ex.ToString());


            }
            return meroxaResponse;
        }


        /// <summary>
        /// Get a list of all resources on this account
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static MeroxaResponse GetResourcelist(string Username, string Token)
        {
            //call GetResourcelist list API

            try
            {
                var DummyResponse = new MeroxaResponse
                {
                    IsSuccessful = true,
                    message = "Resource fetched successfully",
                    data = new data
                    {
                        Metadata = "list of resource"
                    }
                };
                return DummyResponse;

            }
            catch (Exception ex)
            {
                //log exception to API
                Console.Write(ex.ToString());

            }
            return meroxaResponse;
        }


        /// <summary>
        /// delete a resource from it's list
        /// </summary>
        /// <param name="ResourceName"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        public static MeroxaResponse DeleteResource(string ResourceName, string Token)
        {
            //call GetResourcelist list API
            return meroxaResponse;
        }
    }
}
