namespace Tdd.TimeBookings;

public record TimeBooking(DateTime Start, DateTime End, Break? Break);

public record Break(DateTime From, DateTime To);

public record TimeBookingWithValidation(TimeBooking TimeBooking, ValidationResult ValidationResult);

public record ValidationResult(bool IsValid, string ValidationError);
