namespace SuggestionAppLibrary.Models;

public class StatusModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string StsatusName { get; set; }
    public string StatusDescription { get; set; }


}
