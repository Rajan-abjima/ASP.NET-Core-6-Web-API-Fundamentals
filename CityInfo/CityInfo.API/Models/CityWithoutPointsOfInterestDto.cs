namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO fro a city without points of Interest
    /// </summary>
    public class CityWithoutPointsOfInterestDto
    {
        /// <summary>
        /// Th e id of city
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of city
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The description of city
        /// </summary>
        public string? Description { get; set; }
    }
}
