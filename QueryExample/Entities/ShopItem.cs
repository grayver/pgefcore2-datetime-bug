using System;
using System.ComponentModel.DataAnnotations;

namespace QueryExample.Entities
{
    public class ShopItem
    {
        public int Id { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public bool IsSubscription { get; set; }

        public TimeSpan? BaseSubscriptionDuration { get; set; }
    }
}
