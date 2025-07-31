using System.ComponentModel.DataAnnotations;

namespace AD_Coursework.DTOs.CartItem
{
    public class CartItemUpdateDto
    {
        [Required(ErrorMessage = "Book ID is required.")]
        public Guid BookId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}
