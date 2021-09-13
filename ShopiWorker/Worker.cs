using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Flurl.Http;
using shopiApi.Model;
using Flurl;

namespace ShopiWorker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly FlurlClient _flurlClient;

        public Worker(ILogger<Worker> logger)
        {
            _flurlClient = new FlurlClient(Constants.ApiGetUrl);


            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            bool isGet = false;
            while (!stoppingToken.IsCancellationRequested)
            {

                if (!isGet)
                {
                    try
                    {
                        ProductData productData = new();
                        productData = await _flurlClient.Request("product", "52").GetJsonAsync<ProductData>();

                        if (productData.id != null)
                        {
                            ImportProductsRequest importProductsRequest = new()
                            {
                                IntegrationId = productData.id,
                                BaseProductCode = productData.itemId,
                                ColorVariantCode = productData.variants[0].features[0].value,
                                Sku = productData.sku,
                                StockAmount = productData.quantity,
                                Ean = productData.cloudId.ToString(),
                                //TaxRate
                                //Size
                                Title = productData.productName,
                                Headline = productData.headline,
                                Description = productData.productDetailUrl,
                                MainCategory = productData.category.name,
                                //FirstSellingVat
                                //LastSellingVat
                                Color = productData.variants[0].selected.displayName,
                                Image1Link = productData.pictures[0].url,
                                Image2Link = productData.pictures[1].url,
                                Image3Link = productData.pictures[2].url,
                                Image4Link = productData.pictures[3].url,
                                Image5Link = productData.pictures[4].url,
                                WebCategory = productData.category.id,
                                Store = productData.ProductUrl,
                                //IsDeleted
                                //IsUnpublished
                                Variant3 = productData.variants[0].groupName,
                                Variant4 = productData.variants[1].groupName,
                                Filter3 = productData.filters[0].filterItemId,
                                Filter4 = productData.filters[1].filterItemId,
                                Filter5 = productData.filters[2].filterItemId,
                                Filter6 = productData.filters[3].filterItemId,

                            };
                            var result = await Constants.ApiPostUrl.AppendPathSegment("productImport/ImportDeltaProducts").PostJsonAsync(importProductsRequest);
                            _logger.LogInformation(result.ResponseMessage.ToString());
                        }
                        isGet = true;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogInformation(ex.Message);
                    }

                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
