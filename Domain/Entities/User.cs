using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser, I_Entity
    {
        [Required]
        [JsonIgnore]
        public override string PasswordHash { get => base.PasswordHash!; set => base.PasswordHash = value; }

        [JsonIgnore]
        public override string NormalizedUserName { get => base.NormalizedUserName!; set => base.NormalizedUserName = value; }

        [JsonIgnore]
        public override string NormalizedEmail { get => base.NormalizedEmail!; set => base.NormalizedEmail = value; }

        [JsonIgnore]
        public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }

        [JsonIgnore]
        public override string SecurityStamp { get => base.SecurityStamp!; set => base.SecurityStamp = value; }

        [JsonIgnore]
        public override string ConcurrencyStamp { get => base.ConcurrencyStamp!; set => base.ConcurrencyStamp = value; }

        [JsonIgnore]
        public override bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }

        [JsonIgnore]
        public override DateTimeOffset? LockoutEnd { get => base.LockoutEnd; set => base.LockoutEnd = value; }

        [JsonIgnore]
        public override bool LockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }

        [JsonIgnore]
        public override int AccessFailedCount { get => base.AccessFailedCount; set => base.AccessFailedCount = value; }

        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public decimal Points { get; set; } = 0;
        public string Image { get; set; } = string.Empty;
        public string? Piva { get; set; } = string.Empty;
        public string Iban { get; set; } = string.Empty;
        public string? PaypalEmail { get; set; }
        public string ApiToken { get; set; } = string.Empty;
        public string DeviceToken { get; set; } = string.Empty;
        public decimal Earning { get; set; } = 0;
        public bool Available { get; set; } = true;
        public string CurrentState { get; set; } = string.Empty;
        public int? AuthCode { get; set; } = 0;
        public string? TaxCode { get; set; } = string.Empty;
        public DateTime? Born { get; set; } = DateTime.UtcNow;
        public string? Citizenship { get; set; } = string.Empty;

    }
}
