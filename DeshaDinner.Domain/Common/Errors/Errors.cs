using ErrorOr;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Error = ErrorOr.Error;

namespace DeshaDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(
          code: "User.DuplicateEmail",
          description: "Email is already in use"
        );
    }
}
