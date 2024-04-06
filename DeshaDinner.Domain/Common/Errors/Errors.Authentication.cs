using ErrorOr;

namespace DeshaDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Conflict(
            code: "Authentication.InvalidAuth",
            description: "Invalid Credentials"
        );
    }

}
