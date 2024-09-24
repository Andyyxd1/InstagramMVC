using System.ComponentModel.DataAnnotations;

namespace InstagramMVC.Models;

public class Note
{   
    [Required]
    public int NoteId {get; set;}
    public string content {get; set;}

    public string UserId {get; set;}
    public string User User {get; set;}
    
}