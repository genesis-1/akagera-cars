﻿using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities;

public class Auction
{
    public Guid Id { get; set; }
    public int ReservePrice { get; set; } = 0;

    public string Seller { get; set; }
    public int SoldAmout { get; set; }

    public int CurrentHighBid { get; set; } = 0;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public DateTime AuctionEnd { get; set; }

    public Status Status { get; set; }

    public Item Item { get; set; }
    public string Winner { get; set; }

}

