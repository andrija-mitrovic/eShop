using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
    public class UriComposer : IUriComposer
    {
        private readonly string _catalogBaseUrl;

        public UriComposer(string catalogBaseUrl)
        {
            _catalogBaseUrl = catalogBaseUrl;
        }

        public string ComposePicUri(string uriTemplate)
            => uriTemplate.Replace("http://catalogbaseurltobereplaced", _catalogBaseUrl);
    }
}
