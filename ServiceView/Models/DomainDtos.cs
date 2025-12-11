using System.Text.Json.Serialization;

namespace ServiceView.Models;

public sealed record ParticipantDto
{
    public Guid ParticipantId { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public DateTime BirthDate { get; init; }
    public decimal Weight { get; init; }
    public decimal Height { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }

    public string FullName => $"{FirstName} {LastName}".Trim();
}

public sealed record WorkoutDto
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("participantId")]
    public int ParticipantId { get; init; }

    // Backend field is spelled "excercise"
    [JsonPropertyName("excercise")]
    public string Excercise { get; init; } = string.Empty;

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    [JsonPropertyName("repetition")]
    public int Repetition { get; init; }

    // Intensity is numeric in the backend sample
    [JsonPropertyName("intensity")]
    public int Intensity { get; init; }

    [JsonPropertyName("date")]
    public DateTime Date { get; init; }

    [JsonPropertyName("burnedCalories")]
    public int BurnedCalories { get; init; }

    [JsonPropertyName("analyticId")]
    public int AnalyticId { get; init; }
}

public sealed record AnalyticsSnapshot
{
    [JsonPropertyName("id")]
    public int AnalyticsId { get; init; }

    [JsonPropertyName("periodStart")]
    public DateTime PeriodStart { get; init; }

    [JsonPropertyName("periodEnd")]
    public DateTime PeriodEnd { get; init; }

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    [JsonPropertyName("averageDuration")]
    public double AverageDuration { get; init; }

    [JsonPropertyName("totalCalories")]
    public int TotalCalories { get; init; }

    [JsonPropertyName("bestPerformance")]
    public int BestPerformance { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}

public sealed record RecommendationDto
{
    [JsonPropertyName("id")]
    public int RecommendationId { get; init; }

    [JsonPropertyName("participantId")]
    public int ParticipantId { get; init; }

    [JsonPropertyName("recommendationType")]
    public string RecommendationType { get; init; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    [JsonPropertyName("premium")]
    public bool Premium { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}

public sealed record EventDto
{
    public Guid EventId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Location { get; init; } = string.Empty;
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public int MaxParticipants { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public sealed record TicketDto
{
    public Guid TicketId { get; init; }
    public Guid EventId { get; init; }
    public Guid ParticipantId { get; init; }
    public string TicketCode { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public sealed record VehicleDto
{
    public Guid VehicleId { get; init; }
    public string Model { get; init; } = string.Empty;
    public string LicensePlate { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public string CurrentLocation { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public sealed record BookingDto
{
    public Guid BookingId { get; init; }
    public Guid VehicleId { get; init; }
    public Guid ParticipantId { get; init; }
    public DateTime StartTime { get; init; }
    public DateTime EndTime { get; init; }
    public string BookingStatus { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public sealed record PaymentResultDto
{
    public Guid PaymentId { get; init; }
    public Guid ParticipantId { get; init; }
    public string Reference { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
    public DateTime ProcessedAt { get; init; }
}

