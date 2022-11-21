using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{

    public class Partner
    {
        [JsonPropertyName("purchasePartnerPriceList")]
        public object PurchasePartnerPriceList { get; set; }

        [JsonPropertyName("siren")]
        public object Siren { get; set; }

        [JsonPropertyName("das2Activity")]
        public object Das2Activity { get; set; }

        [JsonPropertyName("carrierPartner")]
        public object CarrierPartner { get; set; }

        [JsonPropertyName("nic")]
        public object Nic { get; set; }

        [JsonPropertyName("companyStr")]
        public string CompanyStr { get; set; }

        [JsonPropertyName("partner2SupplychainLinkList")]
        public List<object> Partner2SupplychainLinkList { get; set; }

        [JsonPropertyName("mainActivity")]
        public object MainActivity { get; set; }

        [JsonPropertyName("invoicesCopySelect")]
        public int? InvoicesCopySelect { get; set; }

        [JsonPropertyName("isCarrier")]
        public bool? IsCarrier { get; set; }

        [JsonPropertyName("password")]
        public object Password { get; set; }

        [JsonPropertyName("taxNbr")]
        public object TaxNbr { get; set; }

        [JsonPropertyName("accountingSituationList")]
        public List<AccountingSituation> AccountingSituationList { get; set; }

        [JsonPropertyName("functionBusinessCard")]
        public object FunctionBusinessCard { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("fax")]
        public object Fax { get; set; }

        [JsonPropertyName("contactPartnerSet")]
        public List<ContactPartner> ContactPartnerSet { get; set; }

        [JsonPropertyName("chargeBackPurchaseSelect")]
        public int? ChargeBackPurchaseSelect { get; set; }

        [JsonPropertyName("isEmployee")]
        public bool? IsEmployee { get; set; }

        [JsonPropertyName("groupProductsOnPrintings")]
        public bool? GroupProductsOnPrintings { get; set; }

        [JsonPropertyName("partnerStockSettingsList")]
        public List<PartnerStockSetting> PartnerStockSettingsList { get; set; }

        [JsonPropertyName("purchaseOrderComments")]
        public object PurchaseOrderComments { get; set; }

        [JsonPropertyName("updatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonPropertyName("customerCatalogList")]
        public List<object> CustomerCatalogList { get; set; }

        [JsonPropertyName("mainAddress")]
        public Address MainAddress { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

        [JsonPropertyName("attrs")]
        public object Attrs { get; set; }

        [JsonPropertyName("$wkfStatus")]
        public object WkfStatus { get; set; }

        [JsonPropertyName("mainPartner")]
        public Partner MainPartner { get; set; }

        [JsonPropertyName("partnerAddressList")]
        public List<PartnerAddress> PartnerAddressList { get; set; }

        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonPropertyName("partnerProductQualityRatingList")]
        public List<object> PartnerProductQualityRatingList { get; set; }

        [JsonPropertyName("umrList")]
        public List<object> UmrList { get; set; }

        [JsonPropertyName("factorizedCustomer")]
        public bool? FactorizedCustomer { get; set; }

        [JsonPropertyName("industrySector")]
        public object IndustrySector { get; set; }

        [JsonPropertyName("supplierArrivalProductQty")]
        public string SupplierArrivalProductQty { get; set; }

        [JsonPropertyName("timeSlot")]
        public object TimeSlot { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime? CreatedOn { get; set; }

        [JsonPropertyName("partner1SupplychainLinkList")]
        public List<object> Partner1SupplychainLinkList { get; set; }

        [JsonPropertyName("proformaComments")]
        public object ProformaComments { get; set; }

        [JsonPropertyName("webSite")]
        public object WebSite { get; set; }

        [JsonPropertyName("chargeBackPurchase")]
        public string ChargeBackPurchase { get; set; }

        [JsonPropertyName("partnerSeq")]
        public string PartnerSeq { get; set; }

        [JsonPropertyName("isIspmRequired")]
        public bool? IsIspmRequired { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("tradingName")]
        public object TradingName { get; set; }

        [JsonPropertyName("isProspect")]
        public bool? IsProspect { get; set; }

        [JsonPropertyName("parentPartner")]
        public object ParentPartner { get; set; }

        [JsonPropertyName("hasManuallyBlockedAccount")]
        public bool? HasManuallyBlockedAccount { get; set; }

        [JsonPropertyName("reportsTo")]
        public object ReportsTo { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("picture")]
        public Picture Picture { get; set; }

        [JsonPropertyName("saleTurnover")]
        public int? SaleTurnover { get; set; }

        [JsonPropertyName("headOfficeAddress")]
        public object HeadOfficeAddress { get; set; }

        [JsonPropertyName("importId")]
        public string ImportId { get; set; }

        [JsonPropertyName("pickingOrderComments")]
        public object PickingOrderComments { get; set; }

        [JsonPropertyName("supplierQualityRatingSelect")]
        public string SupplierQualityRatingSelect { get; set; }

        [JsonPropertyName("fiscalPosition")]
        public FiscalPosition FiscalPosition { get; set; }

        [JsonPropertyName("jobTitleFunction")]
        public object JobTitleFunction { get; set; }

        [JsonPropertyName("isNeedingConformityCertificate")]
        public bool? IsNeedingConformityCertificate { get; set; }

        [JsonPropertyName("isSupplier")]
        public bool? IsSupplier { get; set; }

        [JsonPropertyName("linkedUser")]
        public User LinkedUser { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }

        [JsonPropertyName("partnerTypeSelect")]
        public int? PartnerTypeSelect { get; set; }

        [JsonPropertyName("source")]
        public Source Source { get; set; }

        [JsonPropertyName("employee")]
        public object Employee { get; set; }

        [JsonPropertyName("payerQuality")]
        public string PayerQuality { get; set; }

        [JsonPropertyName("titleSelect")]
        public int? TitleSelect { get; set; }

        [JsonPropertyName("emailAddress")]
        public EmailAddress EmailAddress { get; set; }

        [JsonPropertyName("partnerCategory")]
        public PartnerCategory PartnerCategory { get; set; }

        [JsonPropertyName("financialDiscount")]
        public object FinancialDiscount { get; set; }

        [JsonPropertyName("invoiceComments")]
        public object InvoiceComments { get; set; }

        [JsonPropertyName("supplierQualityRating")]
        public string SupplierQualityRating { get; set; }

        [JsonPropertyName("freightCarrierMode")]
        public object FreightCarrierMode { get; set; }

        [JsonPropertyName("selected")]
        public bool? Selected { get; set; }

        [JsonPropertyName("processInstanceId")]
        public object ProcessInstanceId { get; set; }

        [JsonPropertyName("hasBlockedAccount")]
        public bool? HasBlockedAccount { get; set; }

        [JsonPropertyName("updatedBy")]
        public User UpdatedBy { get; set; }

        [JsonPropertyName("isSubcontractor")]
        public bool? IsSubcontractor { get; set; }

        [JsonPropertyName("nbrEmployees")]
        public int? NbrEmployees { get; set; }

        [JsonPropertyName("fixedPhone")]
        public string FixedPhone { get; set; }

        [JsonPropertyName("partnerRoleSet")]
        public List<object> PartnerRoleSet { get; set; }

        [JsonPropertyName("salePartnerPriceList")]
        public object SalePartnerPriceList { get; set; }

        [JsonPropertyName("specificTaxNote")]
        public object SpecificTaxNote { get; set; }

        [JsonPropertyName("blockingList")]
        public List<object> BlockingList { get; set; }

        [JsonPropertyName("isInternal")]
        public bool? IsInternal { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("saleOrderComments")]
        public object SaleOrderComments { get; set; }

        [JsonPropertyName("rejectCounter")]
        public int? RejectCounter { get; set; }

        [JsonPropertyName("simpleFullName")]
        public string SimpleFullName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("outPaymentMode")]
        public PaymentMode OutPaymentMode { get; set; }

        [JsonPropertyName("partnerAttrs")]
        public object PartnerAttrs { get; set; }

        [JsonPropertyName("invoiceSendingFormatSelect")]
        public string InvoiceSendingFormatSelect { get; set; }

        [JsonPropertyName("isContact")]
        public bool? IsContact { get; set; }

        [JsonPropertyName("paymentDelay")]
        public string PaymentDelay { get; set; }

        [JsonPropertyName("importOrigin")]
        public object ImportOrigin { get; set; }

        [JsonPropertyName("complementaryProductList")]
        public List<object> ComplementaryProductList { get; set; }

        [JsonPropertyName("activeUmr")]
        public object ActiveUmr { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("freightCarrierModeList")]
        public List<object> FreightCarrierModeList { get; set; }

        [JsonPropertyName("inPaymentMode")]
        public PaymentMode InPaymentMode { get; set; }

        [JsonPropertyName("batchSet")]
        public List<object> BatchSet { get; set; }

        [JsonPropertyName("purchaseOrderInformation")]
        public object PurchaseOrderInformation { get; set; }

        [JsonPropertyName("customerShippingCarriagePaidList")]
        public List<object> CustomerShippingCarriagePaidList { get; set; }

        [JsonPropertyName("sellerCode")]
        public object SellerCode { get; set; }

        [JsonPropertyName("freightCarrierCustomerAccountNumberList")]
        public List<object> FreightCarrierCustomerAccountNumberList { get; set; }

        [JsonPropertyName("isFactor")]
        public bool? IsFactor { get; set; }

        [JsonPropertyName("registrationCode")]
        public string RegistrationCode { get; set; }

        [JsonPropertyName("companySet")]
        public List<Company> CompanySet { get; set; }

        [JsonPropertyName("department")]
        public object Department { get; set; }

        [JsonPropertyName("saleOrderInformation")]
        public object SaleOrderInformation { get; set; }

        [JsonPropertyName("deliveryDelay")]
        public int? DeliveryDelay { get; set; }

        [JsonPropertyName("supplierCatalogList")]
        public List<SupplierCatalog> SupplierCatalogList { get; set; }

        [JsonPropertyName("paymentCondition")]
        public PaymentCondition PaymentCondition { get; set; }

        [JsonPropertyName("contactAttrs")]
        public object ContactAttrs { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("shipmentMode")]
        public object ShipmentMode { get; set; }

        [JsonPropertyName("bankDetailsList")]
        public List<BankDetail> BankDetailsList { get; set; }

        [JsonPropertyName("isCustomer")]
        public bool? IsCustomer { get; set; }

        [JsonPropertyName("createdBy")]
        public User CreatedBy { get; set; }

        [JsonPropertyName("analyticDistributionTemplate")]
        public object AnalyticDistributionTemplate { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("deliveryComments")]
        public object DeliveryComments { get; set; }
    }



}
