using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace SmartWMS.DTO.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class User
    {
        [JsonPropertyName("transientPassword")]
        public object TransientPassword { get; set; }

        [JsonPropertyName("contextProject")]
        public object ContextProject { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("sendEmailUponPasswordChange")]
        public bool? SendEmailUponPasswordChange { get; set; }

        [JsonPropertyName("employee")]
        public object Employee { get; set; }

        [JsonPropertyName("iCalendar")]
        public object ICalendar { get; set; }

        [JsonPropertyName("workshopStockLocation")]
        public object WorkshopStockLocation { get; set; }

        [JsonPropertyName("permissions")]
        public List<object> Permissions { get; set; }

        [JsonPropertyName("emailAccountList")]
        public List<object> EmailAccountList { get; set; }

        [JsonPropertyName("activateOn")]
        public object ActivateOn { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("passwordUpdatedOn")]
        public object PasswordUpdatedOn { get; set; }

        [JsonPropertyName("projectSet")]
        public List<object> ProjectSet { get; set; }

        [JsonPropertyName("followedMetaModelSet")]
        public List<object> FollowedMetaModelSet { get; set; }

        [JsonPropertyName("selected")]
        public bool? Selected { get; set; }

        [JsonPropertyName("group")]
        public Group Group { get; set; }

        [JsonPropertyName("processInstanceId")]
        public object ProcessInstanceId { get; set; }

        [JsonPropertyName("updatedBy")]
        public User UpdatedBy { get; set; }

        [JsonPropertyName("metaPermissions")]
        public List<object> MetaPermissions { get; set; }

        [JsonPropertyName("updatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

        [JsonPropertyName("emailSignature")]
        public object EmailSignature { get; set; }

        [JsonPropertyName("todayDateT")]
        public object TodayDateT { get; set; }

        [JsonPropertyName("attrs")]
        public object Attrs { get; set; }

        [JsonPropertyName("$wkfStatus")]
        public object WkfStatus { get; set; }

        [JsonPropertyName("appPermissions")]
        public string AppPermissions { get; set; }

        [JsonPropertyName("electronicSignature")]
        public object ElectronicSignature { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("homeAction")]
        public object HomeAction { get; set; }

        [JsonPropertyName("useSignatureForStock")]
        public bool? UseSignatureForStock { get; set; }

        [JsonPropertyName("importOrigin")]
        public object ImportOrigin { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("roles")]
        public List<object> Roles { get; set; }

        [JsonPropertyName("singleTab")]
        public bool? SingleTab { get; set; }

        [JsonPropertyName("activeCompany")]
        public object ActiveCompany { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime? CreatedOn { get; set; }

        [JsonPropertyName("isIncludeSubContextProjects")]
        public bool? IsIncludeSubContextProjects { get; set; }

        [JsonPropertyName("noHelp")]
        public bool? NoHelp { get; set; }

        [JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        [JsonPropertyName("activeTeam")]
        public object ActiveTeam { get; set; }

        [JsonPropertyName("useSignatureForPurchaseQuotations")]
        public bool? UseSignatureForPurchaseQuotations { get; set; }

        [JsonPropertyName("isSuperPfpUser")]
        public bool? IsSuperPfpUser { get; set; }

        [JsonPropertyName("substitutePfpValidatorList")]
        public List<object> SubstitutePfpValidatorList { get; set; }

        [JsonPropertyName("calendarManagementList")]
        public List<object> CalendarManagementList { get; set; }

        [JsonPropertyName("expiresOn")]
        public object ExpiresOn { get; set; }

        [JsonPropertyName("theme")]
        public string Theme { get; set; }

        [JsonPropertyName("companySet")]
        public List<object> CompanySet { get; set; }

        [JsonPropertyName("email")]
        public object Email { get; set; }

        [JsonPropertyName("tradingName")]
        public object TradingName { get; set; }

        [JsonPropertyName("useSignatureForSalesQuotations")]
        public bool? UseSignatureForSalesQuotations { get; set; }

        [JsonPropertyName("isPfpValidator")]
        public bool? IsPfpValidator { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("stepStatusSelect")]
        public int? StepStatusSelect { get; set; }

        [JsonPropertyName("followersCalUserSet")]
        public List<object> FollowersCalUserSet { get; set; }

        [JsonPropertyName("receiveEmails")]
        public bool? ReceiveEmails { get; set; }

        [JsonPropertyName("importId")]
        public string ImportId { get; set; }

        [JsonPropertyName("teamSet")]
        public List<object> TeamSet { get; set; }

        [JsonPropertyName("partner")]
        public object Partner { get; set; }

        [JsonPropertyName("createdBy")]
        public User CreatedBy { get; set; }

        [JsonPropertyName("forcePasswordChange")]
        public bool? ForcePasswordChange { get; set; }
    }


}
