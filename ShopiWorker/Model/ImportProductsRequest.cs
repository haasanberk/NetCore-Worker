using System.Collections.Generic;

namespace shopiApi.Model
{
   
    public class ImportProductsRequest
    {

        public string IntegrationId { get; set; } //id
        public string BaseProductCode { get; set; } //itemId
        public string ColorVariantCode { get; set; } //variants.features.value
        public string Sku { get; set; } //sku
        public string StockAmount { get; set; } //quantity
        public string Ean { get; set; } //cloudId
        public string TaxRate { get; set; } //
        public string Size { get; set; } //
        public string Title { get; set; } //productName
        public string Headline { get; set; } //headline
        public string Description { get; set; } //productDetailUrl
        public string MainCategory { get; set; } //category.name
        public string FirstSellingVat { get; set; }//
        public string LastSellingVat { get; set; }//
        public string Color { get; set; }//variants.selected.displayname
        public string Image1Link { get; set; }//pictures
        public string Image2Link { get; set; }//pictures
        public string Image3Link { get; set; }//pictures
        public string Image4Link { get; set; }//pictures
        public string Image5Link { get; set; }//pictures
        public string WebCategory { get; set; }//category.id
        public string Store { get; set; }//productUrl
        public string IsDeleted { get; set; }//
        public string IsUnpublished { get; set; }//
        public string Variant3 { get; set; }//variants.groupname1
        public string Variant4 { get; set; }//variants.groupname1
        public string Filter3 { get; set; }//filters.filterItemId
        public string Filter4 { get; set; }//filters.filterItemId
        public string Filter5 { get; set; }//filters.filterItemId
        public string Filter6 { get; set; }//filters.filterItemId
    }
}