using System.Xml.Serialization;

namespace Timbrado.CFDIS.Detallista.AMC71
{
    public class DetallistaAMC71
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(Root));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (Root)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "requestForPaymentIdentification")]
        public class RequestForPaymentIdentification
        {

            [XmlElement(ElementName = "entityType")]
            public string EntityType { get; set; }

            [XmlElement(ElementName = "uniqueCreatorIdentification")]
            public string UniqueCreatorIdentification { get; set; }
        }

        [XmlRoot(ElementName = "specialInstruction")]
        public class SpecialInstruction
        {

            [XmlElement(ElementName = "text")]
            public List<string> Text { get; set; }

            [XmlAttribute(AttributeName = "code")]
            public string Code { get; set; }
        }

        [XmlRoot(ElementName = "referenceIdentification")]
        public class ReferenceIdentification
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "orderIdentification")]
        public class OrderIdentification
        {

            [XmlElement(ElementName = "referenceIdentification")]
            public ReferenceIdentification ReferenceIdentification { get; set; }

            [XmlElement(ElementName = "ReferenceDate")]
            public string ReferenceDate { get; set; }
        }

        [XmlRoot(ElementName = "DeliveryNote")]
        public class DeliveryNote
        {

            [XmlElement(ElementName = "referenceIdentification")]
            public string ReferenceIdentification { get; set; }

            [XmlElement(ElementName = "ReferenceDate")]
            public string ReferenceDate { get; set; }
        }

        [XmlRoot(ElementName = "buyer")]
        public class Buyer
        {

            [XmlElement(ElementName = "gln")]
            public string Gln { get; set; }
        }

        [XmlRoot(ElementName = "alternatePartyIdentification")]
        public class AlternatePartyIdentification
        {

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "seller")]
        public class Seller
        {

            [XmlElement(ElementName = "gln")]
            public string Gln { get; set; }

            [XmlElement(ElementName = "alternatePartyIdentification")]
            public AlternatePartyIdentification AlternatePartyIdentification { get; set; }
        }

        [XmlRoot(ElementName = "nameAndAddress")]
        public class NameAndAddress
        {

            [XmlElement(ElementName = "name")]
            public string Name { get; set; }

            [XmlElement(ElementName = "streetAddressOne")]
            public string StreetAddressOne { get; set; }

            [XmlElement(ElementName = "city")]
            public string City { get; set; }

            [XmlElement(ElementName = "postalCode")]
            public string PostalCode { get; set; }
        }

        [XmlRoot(ElementName = "shipTo")]
        public class ShipTo
        {

            [XmlElement(ElementName = "gln")]
            public string Gln { get; set; }

            [XmlElement(ElementName = "nameAndAddress")]
            public NameAndAddress NameAndAddress { get; set; }
        }

        [XmlRoot(ElementName = "currency")]
        public class Currency
        {

            [XmlElement(ElementName = "currencyFunction")]
            public string CurrencyFunction { get; set; }

            [XmlElement(ElementName = "rateOfChange")]
            public string RateOfChange { get; set; }

            [XmlAttribute(AttributeName = "currencyISOCode")]
            public string CurrencyISOCode { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "timePeriodDue")]
        public class TimePeriodDue
        {

            [XmlElement(ElementName = "value")]
            public string Value { get; set; }

            [XmlAttribute(AttributeName = "timePeriod")]
            public string TimePeriod { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "paymentTimePeriod")]
        public class PaymentTimePeriod
        {

            [XmlElement(ElementName = "timePeriodDue")]
            public TimePeriodDue TimePeriodDue { get; set; }
        }

        [XmlRoot(ElementName = "netPayment")]
        public class NetPayment
        {

            [XmlElement(ElementName = "paymentTimePeriod")]
            public PaymentTimePeriod PaymentTimePeriod { get; set; }

            [XmlAttribute(AttributeName = "netPaymentTermsType")]
            public string NetPaymentTermsType { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "paymentTerms")]
        public class PaymentTerms
        {

            [XmlElement(ElementName = "netPayment")]
            public NetPayment NetPayment { get; set; }

            [XmlAttribute(AttributeName = "paymentTermsEvent")]
            public string PaymentTermsEvent { get; set; }

            [XmlAttribute(AttributeName = "PaymentTermsRelationTime")]
            public string PaymentTermsRelationTime { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "rate")]
        public class Rate
        {

            [XmlElement(ElementName = "percentage")]
            public string Percentage { get; set; }

            [XmlAttribute(AttributeName = "base")]
            public string Base { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "monetaryAmountOrPercentage")]
        public class MonetaryAmountOrPercentage
        {

            [XmlElement(ElementName = "rate")]
            public Rate Rate { get; set; }
        }

        [XmlRoot(ElementName = "allowanceCharge")]
        public class AllowanceCharge
        {

            [XmlElement(ElementName = "specialServicesType")]
            public string SpecialServicesType { get; set; }

            [XmlElement(ElementName = "monetaryAmountOrPercentage")]
            public MonetaryAmountOrPercentage MonetaryAmountOrPercentage { get; set; }

            [XmlAttribute(AttributeName = "settlementType")]
            public string SettlementType { get; set; }

            [XmlAttribute(AttributeName = "allowanceChargeType")]
            public string AllowanceChargeType { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "tradeItemIdentification")]
        public class TradeItemIdentification
        {

            [XmlElement(ElementName = "gtin")]
            public string Gtin { get; set; }
        }

        [XmlRoot(ElementName = "tradeItemDescriptionInformation")]
        public class TradeItemDescriptionInformation
        {

            [XmlElement(ElementName = "LongText")]
            public string LongText { get; set; }

            [XmlAttribute(AttributeName = "language")]
            public string Language { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "invoicedQuantity")]
        public class InvoicedQuantity
        {

            [XmlAttribute(AttributeName = "unitOfMeasure")]
            public string UnitOfMeasure { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "aditionalQuantity")]
        public class AditionalQuantity
        {

            [XmlAttribute(AttributeName = "QuantityType")]
            public string QuantityType { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "AdditionalInformation")]
        public class AdditionalInformation
        {

            [XmlElement(ElementName = "referenceIdentification")]
            public string ReferenceIdentification { get; set; }
        }

        [XmlRoot(ElementName = "grossPrice")]
        public class GrossPrice
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "netPrice")]
        public class NetPrice
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "tradeItemTaxAmount")]
        public class TradeItemTaxAmount
        {

            [XmlElement(ElementName = "taxPercentage")]
            public string TaxPercentage { get; set; }

            [XmlElement(ElementName = "taxAmount")]
            public string TaxAmount { get; set; }
        }

        [XmlRoot(ElementName = "tradeItemTaxInformation")]
        public class TradeItemTaxInformation
        {

            [XmlElement(ElementName = "taxTypeDescription")]
            public string TaxTypeDescription { get; set; }

            [XmlElement(ElementName = "tradeItemTaxAmount")]
            public TradeItemTaxAmount TradeItemTaxAmount { get; set; }
        }

        [XmlRoot(ElementName = "grossAmount")]
        public class GrossAmount
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "netAmount")]
        public class NetAmount
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "totalLineAmount")]
        public class TotalLineAmount
        {

            [XmlElement(ElementName = "grossAmount")]
            public GrossAmount GrossAmount { get; set; }

            [XmlElement(ElementName = "netAmount")]
            public NetAmount NetAmount { get; set; }
        }

        [XmlRoot(ElementName = "lineItem")]
        public class LineItem
        {

            [XmlElement(ElementName = "tradeItemIdentification")]
            public TradeItemIdentification TradeItemIdentification { get; set; }

            [XmlElement(ElementName = "tradeItemDescriptionInformation")]
            public TradeItemDescriptionInformation TradeItemDescriptionInformation { get; set; }

            [XmlElement(ElementName = "invoicedQuantity")]
            public InvoicedQuantity InvoicedQuantity { get; set; }

            [XmlElement(ElementName = "aditionalQuantity")]
            public AditionalQuantity AditionalQuantity { get; set; }

            [XmlElement(ElementName = "AdditionalInformation")]
            public AdditionalInformation AdditionalInformation { get; set; }

            [XmlElement(ElementName = "grossPrice")]
            public GrossPrice GrossPrice { get; set; }

            [XmlElement(ElementName = "netPrice")]
            public NetPrice NetPrice { get; set; }

            [XmlElement(ElementName = "tradeItemTaxInformation")]
            public TradeItemTaxInformation TradeItemTaxInformation { get; set; }

            [XmlElement(ElementName = "totalLineAmount")]
            public TotalLineAmount TotalLineAmount { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlAttribute(AttributeName = "number")]
            public string Number { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "totalAmount")]
        public class TotalAmount
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "totalAllowanceCharge")]
        public class TotalAllowanceCharge
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }

            [XmlAttribute(AttributeName = "allowanceOrChargeType")]
            public string AllowanceOrChargeType { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "baseAmount")]
        public class BaseAmount
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "tax")]
        public class Tax
        {

            [XmlElement(ElementName = "taxPercentage")]
            public string TaxPercentage { get; set; }

            [XmlElement(ElementName = "taxAmount")]
            public string TaxAmount { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "payableAmount")]
        public class PayableAmount
        {

            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
        }

        [XmlRoot(ElementName = "requestForPayment")]
        public class RequestForPayment
        {

            [XmlElement(ElementName = "requestForPaymentIdentification")]
            public RequestForPaymentIdentification RequestForPaymentIdentification { get; set; }

            [XmlElement(ElementName = "specialInstruction")]
            public List<SpecialInstruction> SpecialInstruction { get; set; }

            [XmlElement(ElementName = "orderIdentification")]
            public OrderIdentification OrderIdentification { get; set; }

            [XmlElement(ElementName = "DeliveryNote")]
            public DeliveryNote DeliveryNote { get; set; }

            [XmlElement(ElementName = "buyer")]
            public Buyer Buyer { get; set; }

            [XmlElement(ElementName = "seller")]
            public Seller Seller { get; set; }

            [XmlElement(ElementName = "shipTo")]
            public ShipTo ShipTo { get; set; }

            [XmlElement(ElementName = "currency")]
            public Currency Currency { get; set; }

            [XmlElement(ElementName = "paymentTerms")]
            public PaymentTerms PaymentTerms { get; set; }

            [XmlElement(ElementName = "allowanceCharge")]
            public AllowanceCharge AllowanceCharge { get; set; }

            [XmlElement(ElementName = "lineItem")]
            public List<LineItem> LineItem { get; set; }

            [XmlElement(ElementName = "totalAmount")]
            public TotalAmount TotalAmount { get; set; }

            [XmlElement(ElementName = "totalAllowanceCharge")]
            public TotalAllowanceCharge TotalAllowanceCharge { get; set; }

            [XmlElement(ElementName = "baseAmount")]
            public BaseAmount BaseAmount { get; set; }

            [XmlElement(ElementName = "tax")]
            public Tax Tax { get; set; }

            [XmlElement(ElementName = "payableAmount")]
            public PayableAmount PayableAmount { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }

            [XmlAttribute(AttributeName = "contentVersion")]
            public string ContentVersion { get; set; }

            [XmlAttribute(AttributeName = "documentStructureVersion")]
            public string DocumentStructureVersion { get; set; }

            [XmlAttribute(AttributeName = "documentStatus")]
            public string DocumentStatus { get; set; }

            [XmlAttribute(AttributeName = "DeliveryDate")]
            public string DeliveryDate { get; set; }

            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Addenda")]
        public class Addenda
        {

            [XmlElement(ElementName = "requestForPayment")]
            public RequestForPayment RequestForPayment { get; set; }
        }

        [XmlRoot(ElementName = "Root")]
        public class Root
        {

            [XmlElement(ElementName = "Addenda")]
            public Addenda Addenda { get; set; }

            [XmlAttribute(AttributeName = "cfdi")]
            public string Cfdi { get; set; }

            [XmlText]
            public string Text { get; set; }
        }


    }
}
