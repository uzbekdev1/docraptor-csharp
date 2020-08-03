/*
 * DocRaptor
 *
 * A native client library for the DocRaptor HTML to PDF/XLS service.
 *
 * OpenAPI spec version: 2.0.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocRaptor.Client.SwaggerDateConverter;

namespace DocRaptor.Model
{
    /// <summary>
    /// Doc
    /// </summary>
    [DataContract]
    public partial class Doc :  IEquatable<Doc>, IValidatableObject
    {
        /// <summary>
        /// The type of document being created.
        /// </summary>
        /// <value>The type of document being created.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {

            /// <summary>
            /// Enum Pdf for value: pdf
            /// </summary>
            [EnumMember(Value = "pdf")]
            Pdf = 1,

            /// <summary>
            /// Enum Xls for value: xls
            /// </summary>
            [EnumMember(Value = "xls")]
            Xls = 2,

            /// <summary>
            /// Enum Xlsx for value: xlsx
            /// </summary>
            [EnumMember(Value = "xlsx")]
            Xlsx = 3
        }

        /// <summary>
        /// The type of document being created.
        /// </summary>
        /// <value>The type of document being created.</value>
        [DataMember(Name="document_type", EmitDefaultValue=false)]
        public DocumentTypeEnum DocumentType { get; set; }
        /// <summary>
        /// Force strict HTML validation.
        /// </summary>
        /// <value>Force strict HTML validation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrictEnum
        {

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 2
        }

        /// <summary>
        /// Force strict HTML validation.
        /// </summary>
        /// <value>Force strict HTML validation.</value>
        [DataMember(Name="strict", EmitDefaultValue=false)]
        public StrictEnum? Strict { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Doc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Doc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Doc" /> class.
        /// </summary>
        /// <param name="name">A name for identifying your document. (required).</param>
        /// <param name="documentType">The type of document being created. (required).</param>
        /// <param name="documentContent">The HTML data to be transformed into a document. You must supply content using document_content or document_url.  (required).</param>
        /// <param name="documentUrl">The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url. .</param>
        /// <param name="test">Enable test mode for this document. Test documents are not charged for but include a watermark. (default to true).</param>
        /// <param name="pipeline">Specify a specific verison of the DocRaptor Pipeline to use..</param>
        /// <param name="strict">Force strict HTML validation..</param>
        /// <param name="ignoreResourceErrors">Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop. (default to true).</param>
        /// <param name="ignoreConsoleMessages">Prevent console.log from stopping document rendering during JavaScript execution. (default to false).</param>
        /// <param name="tag">A field for storing a small amount of metadata with this document..</param>
        /// <param name="help">Request support help with this request if it succeeds. (default to false).</param>
        /// <param name="javascript">Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere. (default to false).</param>
        /// <param name="referrer">Set HTTP referrer when generating this document..</param>
        /// <param name="callbackUrl">A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status API responses. WARNING: this only works on asynchronous documents. .</param>
        /// <param name="hostedDownloadLimit">The number of times a hosted document can be downloaded.  If no limit is specified, the document will be available for an unlimited number of downloads..</param>
        /// <param name="hostedExpiresAt">The date and time at which a hosted document will be removed and no longer available. Must be a properly formatted ISO 8601 datetime, like 1981-01-23T08:02:30-05:00..</param>
        /// <param name="princeOptions">princeOptions.</param>
        public Doc(string name = default(string), DocumentTypeEnum documentType = default(DocumentTypeEnum), string documentContent = default(string), string documentUrl = default(string), bool? test = true, string pipeline = default(string), StrictEnum? strict = default(StrictEnum?), bool? ignoreResourceErrors = true, bool? ignoreConsoleMessages = false, string tag = default(string), bool? help = false, bool? javascript = false, string referrer = default(string), string callbackUrl = default(string), int? hostedDownloadLimit = default(int?), string hostedExpiresAt = default(string), PrinceOptions princeOptions = default(PrinceOptions))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Doc and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new InvalidDataException("documentType is a required property for Doc and cannot be null");
            }
            else
            {
                this.DocumentType = documentType;
            }
            // to ensure "documentContent" is required (not null)
            if (documentContent == null)
            {
                throw new InvalidDataException("documentContent is a required property for Doc and cannot be null");
            }
            else
            {
                this.DocumentContent = documentContent;
            }
            this.DocumentUrl = documentUrl;
            // use default value if no "test" provided
            if (test == null)
            {
                this.Test = true;
            }
            else
            {
                this.Test = test;
            }
            this.Pipeline = pipeline;
            this.Strict = strict;
            // use default value if no "ignoreResourceErrors" provided
            if (ignoreResourceErrors == null)
            {
                this.IgnoreResourceErrors = true;
            }
            else
            {
                this.IgnoreResourceErrors = ignoreResourceErrors;
            }
            // use default value if no "ignoreConsoleMessages" provided
            if (ignoreConsoleMessages == null)
            {
                this.IgnoreConsoleMessages = false;
            }
            else
            {
                this.IgnoreConsoleMessages = ignoreConsoleMessages;
            }
            this.Tag = tag;
            // use default value if no "help" provided
            if (help == null)
            {
                this.Help = false;
            }
            else
            {
                this.Help = help;
            }
            // use default value if no "javascript" provided
            if (javascript == null)
            {
                this.Javascript = false;
            }
            else
            {
                this.Javascript = javascript;
            }
            this.Referrer = referrer;
            this.CallbackUrl = callbackUrl;
            this.HostedDownloadLimit = hostedDownloadLimit;
            this.HostedExpiresAt = hostedExpiresAt;
            this.PrinceOptions = princeOptions;
        }

        /// <summary>
        /// A name for identifying your document.
        /// </summary>
        /// <value>A name for identifying your document.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// The HTML data to be transformed into a document. You must supply content using document_content or document_url.
        /// </summary>
        /// <value>The HTML data to be transformed into a document. You must supply content using document_content or document_url. </value>
        [DataMember(Name="document_content", EmitDefaultValue=false)]
        public string DocumentContent { get; set; }

        /// <summary>
        /// The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url.
        /// </summary>
        /// <value>The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url. </value>
        [DataMember(Name="document_url", EmitDefaultValue=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// Enable test mode for this document. Test documents are not charged for but include a watermark.
        /// </summary>
        /// <value>Enable test mode for this document. Test documents are not charged for but include a watermark.</value>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public bool? Test { get; set; }

        /// <summary>
        /// Specify a specific verison of the DocRaptor Pipeline to use.
        /// </summary>
        /// <value>Specify a specific verison of the DocRaptor Pipeline to use.</value>
        [DataMember(Name="pipeline", EmitDefaultValue=false)]
        public string Pipeline { get; set; }


        /// <summary>
        /// Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop.
        /// </summary>
        /// <value>Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop.</value>
        [DataMember(Name="ignore_resource_errors", EmitDefaultValue=false)]
        public bool? IgnoreResourceErrors { get; set; }

        /// <summary>
        /// Prevent console.log from stopping document rendering during JavaScript execution.
        /// </summary>
        /// <value>Prevent console.log from stopping document rendering during JavaScript execution.</value>
        [DataMember(Name="ignore_console_messages", EmitDefaultValue=false)]
        public bool? IgnoreConsoleMessages { get; set; }

        /// <summary>
        /// A field for storing a small amount of metadata with this document.
        /// </summary>
        /// <value>A field for storing a small amount of metadata with this document.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Request support help with this request if it succeeds.
        /// </summary>
        /// <value>Request support help with this request if it succeeds.</value>
        [DataMember(Name="help", EmitDefaultValue=false)]
        public bool? Help { get; set; }

        /// <summary>
        /// Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere.
        /// </summary>
        /// <value>Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere.</value>
        [DataMember(Name="javascript", EmitDefaultValue=false)]
        public bool? Javascript { get; set; }

        /// <summary>
        /// Set HTTP referrer when generating this document.
        /// </summary>
        /// <value>Set HTTP referrer when generating this document.</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public string Referrer { get; set; }

        /// <summary>
        /// A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status API responses. WARNING: this only works on asynchronous documents.
        /// </summary>
        /// <value>A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status API responses. WARNING: this only works on asynchronous documents. </value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The number of times a hosted document can be downloaded.  If no limit is specified, the document will be available for an unlimited number of downloads.
        /// </summary>
        /// <value>The number of times a hosted document can be downloaded.  If no limit is specified, the document will be available for an unlimited number of downloads.</value>
        [DataMember(Name="hosted_download_limit", EmitDefaultValue=false)]
        public int? HostedDownloadLimit { get; set; }

        /// <summary>
        /// The date and time at which a hosted document will be removed and no longer available. Must be a properly formatted ISO 8601 datetime, like 1981-01-23T08:02:30-05:00.
        /// </summary>
        /// <value>The date and time at which a hosted document will be removed and no longer available. Must be a properly formatted ISO 8601 datetime, like 1981-01-23T08:02:30-05:00.</value>
        [DataMember(Name="hosted_expires_at", EmitDefaultValue=false)]
        public string HostedExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets PrinceOptions
        /// </summary>
        [DataMember(Name="prince_options", EmitDefaultValue=false)]
        public PrinceOptions PrinceOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Doc {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DocumentContent: ").Append(DocumentContent).Append("\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Strict: ").Append(Strict).Append("\n");
            sb.Append("  IgnoreResourceErrors: ").Append(IgnoreResourceErrors).Append("\n");
            sb.Append("  IgnoreConsoleMessages: ").Append(IgnoreConsoleMessages).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Help: ").Append(Help).Append("\n");
            sb.Append("  Javascript: ").Append(Javascript).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  HostedDownloadLimit: ").Append(HostedDownloadLimit).Append("\n");
            sb.Append("  HostedExpiresAt: ").Append(HostedExpiresAt).Append("\n");
            sb.Append("  PrinceOptions: ").Append(PrinceOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Doc);
        }

        /// <summary>
        /// Returns true if Doc instances are equal
        /// </summary>
        /// <param name="input">Instance of Doc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Doc input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) &&
                (
                    this.DocumentContent == input.DocumentContent ||
                    (this.DocumentContent != null &&
                    this.DocumentContent.Equals(input.DocumentContent))
                ) &&
                (
                    this.DocumentUrl == input.DocumentUrl ||
                    (this.DocumentUrl != null &&
                    this.DocumentUrl.Equals(input.DocumentUrl))
                ) &&
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                ) &&
                (
                    this.Pipeline == input.Pipeline ||
                    (this.Pipeline != null &&
                    this.Pipeline.Equals(input.Pipeline))
                ) &&
                (
                    this.Strict == input.Strict ||
                    (this.Strict != null &&
                    this.Strict.Equals(input.Strict))
                ) &&
                (
                    this.IgnoreResourceErrors == input.IgnoreResourceErrors ||
                    (this.IgnoreResourceErrors != null &&
                    this.IgnoreResourceErrors.Equals(input.IgnoreResourceErrors))
                ) &&
                (
                    this.IgnoreConsoleMessages == input.IgnoreConsoleMessages ||
                    (this.IgnoreConsoleMessages != null &&
                    this.IgnoreConsoleMessages.Equals(input.IgnoreConsoleMessages))
                ) &&
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) &&
                (
                    this.Help == input.Help ||
                    (this.Help != null &&
                    this.Help.Equals(input.Help))
                ) &&
                (
                    this.Javascript == input.Javascript ||
                    (this.Javascript != null &&
                    this.Javascript.Equals(input.Javascript))
                ) &&
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
                ) &&
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) &&
                (
                    this.HostedDownloadLimit == input.HostedDownloadLimit ||
                    (this.HostedDownloadLimit != null &&
                    this.HostedDownloadLimit.Equals(input.HostedDownloadLimit))
                ) &&
                (
                    this.HostedExpiresAt == input.HostedExpiresAt ||
                    (this.HostedExpiresAt != null &&
                    this.HostedExpiresAt.Equals(input.HostedExpiresAt))
                ) &&
                (
                    this.PrinceOptions == input.PrinceOptions ||
                    (this.PrinceOptions != null &&
                    this.PrinceOptions.Equals(input.PrinceOptions))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.DocumentContent != null)
                    hashCode = hashCode * 59 + this.DocumentContent.GetHashCode();
                if (this.DocumentUrl != null)
                    hashCode = hashCode * 59 + this.DocumentUrl.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.Pipeline != null)
                    hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.Strict != null)
                    hashCode = hashCode * 59 + this.Strict.GetHashCode();
                if (this.IgnoreResourceErrors != null)
                    hashCode = hashCode * 59 + this.IgnoreResourceErrors.GetHashCode();
                if (this.IgnoreConsoleMessages != null)
                    hashCode = hashCode * 59 + this.IgnoreConsoleMessages.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Help != null)
                    hashCode = hashCode * 59 + this.Help.GetHashCode();
                if (this.Javascript != null)
                    hashCode = hashCode * 59 + this.Javascript.GetHashCode();
                if (this.Referrer != null)
                    hashCode = hashCode * 59 + this.Referrer.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.HostedDownloadLimit != null)
                    hashCode = hashCode * 59 + this.HostedDownloadLimit.GetHashCode();
                if (this.HostedExpiresAt != null)
                    hashCode = hashCode * 59 + this.HostedExpiresAt.GetHashCode();
                if (this.PrinceOptions != null)
                    hashCode = hashCode * 59 + this.PrinceOptions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
