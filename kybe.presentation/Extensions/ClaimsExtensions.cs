using System.Security.Claims;

namespace kybe.presentation.Extensions
{
    public static class ClaimsExtensions
    {
        public static Guid GetUserId(this ClaimsPrincipal user)
        {
            var value = user.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!Guid.TryParse(value, out var id))
                throw new InvalidOperationException(
                    "Identificador do usuário não encontrado."
                );

            return id;
        }

        public static string GetName(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.Name) ?? string.Empty;
        }

        public static string GetLastName(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.Surname) ?? string.Empty;
        }

        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirstValue("UserName") ?? string.Empty;
        }
    }
}
