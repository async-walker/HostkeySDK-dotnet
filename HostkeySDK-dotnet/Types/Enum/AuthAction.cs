namespace Hostkey.SDK.Types.Enum;

/// <summary>
/// Действие для авторизации
/// </summary>
public enum AuthAction
{
    /// <summary>
    /// Получить сессионный токен через API ключ аккаунта или сервера
    /// </summary>
    Login = 0,
    /// <summary>
    /// Получить сессионный токен через пару логин-пароль аккаунта
    /// </summary>
    WhmcsLogin = 1,
    /// <summary>
    /// Завершить клиентскую сессию
    /// </summary>
    Logout = 2,
    /// <summary>
    /// Получить данные о пользователе (доступные API-запросы, тип и роль аккаунта и id-серверов привязанных к учетной записи)
    /// </summary>
    Info = 3
}