using System.Text.Json.Serialization;

namespace SimplePlantsApi.Models
{
    public class Plant
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("common_name")]
        public string CommonName { get; set; }
        [JsonPropertyName("scientific_name")]
        public List<string> ScientificName { get; set; }
        [JsonPropertyName("other_name")]
        public List<string> OtherName { get; set; }
        [JsonPropertyName("cycle")]
        public string Cycle { get; set; }
        [JsonPropertyName("watering")]
        public string Watering { get; set; }
        [JsonPropertyName("sunlight")]
        public List<string> Sunlight { get; set; }
        [JsonPropertyName("default_image")]
        public ImageInfo DefaultImage { get; set; }

        public Plant(int id, string commonName, List<string> scientificName, List<string> otherName, string cycle, string watering, List<string> sunlight, ImageInfo defaultImage)
        {
            CommonName = commonName;
            ScientificName = scientificName;
            Id = id;
            OtherName = otherName;
            Cycle = cycle;
            Watering = watering;
            Sunlight = sunlight;
            DefaultImage = defaultImage;
        }
    }

    public class ImageInfo
    {
        [JsonPropertyName("license")]
        public int License { get; set; }
        [JsonPropertyName("license_name")]
        public string LicenseName { get; set; }
        [JsonPropertyName("license_url")]
        public string LicenseUrl { get; set; }
        [JsonPropertyName("original_url")]
        public string OriginalUrl { get; set; }
        [JsonPropertyName("regular_url")]
        public string RegularUrl { get; set; }
        [JsonPropertyName("medium_url")]
        public string MediumUrl { get; set; }
        [JsonPropertyName("small_url")]
        public string SmallUrl { get; set; }
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        public ImageInfo(int license, string licenseName, string licenseUrl, string thumbnail, string originalUrl, string regularUrl, string mediumUrl, string smallUrl)
        {
            License = license;
            LicenseName = licenseName;
            LicenseUrl = licenseUrl;
            Thumbnail = thumbnail;
            OriginalUrl = originalUrl;
            RegularUrl = regularUrl;
            MediumUrl = mediumUrl;
            SmallUrl = smallUrl;
        }
    }
}