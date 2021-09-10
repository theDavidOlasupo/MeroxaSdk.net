using System;
namespace Meroxa.net.helpers.Models
{

    public class Constants
    {
        /// <summary>
        /// The name of the property needed in the resource creation
        /// when <code>ForContext&lt;T&gt;()</code> and overloads are
        /// applied.
        /// </summary>
        public const string Azure = "AzureCosmos";
        public const string AWS = "AWS";
        public const string MongoDB = "MongoDb";
        public const string PostGreSql = "SourceContext";
        public const string BigQuery = "SourceContext";
        public const string s3 = "S3Bucket";
        public const string Redshift = "Redshift";
        public const string MYSQL = "MYSQL";
        public const string ElasticSearch = "ElasticSearch";
        public const string Snowflake = "Snowflake";
        public const string Webhook = "Webhook";
    }
}
