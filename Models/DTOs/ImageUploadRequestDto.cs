using System.ComponentModel.DataAnnotations;

namespace CaminhadasAPI.Models.DTOs; 

public class ImageUploadRequestDto {
    [Required] public IFormFile File { get; set; }
    [Required] public string FileName { get; set; }
    public string? FileDescription { get; set; }
}