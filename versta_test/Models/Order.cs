using System.ComponentModel.DataAnnotations;

namespace versta_test.Models;

public class Order
{
    public int Id { get; set; }

    [Required]
    public string SenderCity { get; set; }

    [Required]
    public string SenderAddress { get; set; }

    [Required]
    public string ReceiverCity { get; set; }

    [Required]
    public string ReceiverAddress { get; set; }

    [Required]
    public double Weight { get; set; }

    [Required]
    public DateTime PickupDate { get; set; }
}