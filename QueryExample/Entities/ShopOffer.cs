using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryExample.Entities
{
    public class ShopOffer
    {
        public int Id { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public string Name { get; set; }

        public TimeSpan? SubscriptionDuration { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset? ExpiresAt { get; set; }

        public int? Position { get; set; }


        [ForeignKey("ShopItemId")]
        public ShopItem Item { get; set; }
    }
}
