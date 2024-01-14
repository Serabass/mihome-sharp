namespace MihomeCLI;

// https://github.com/maxinminax/node-mihome/blob/master/lib/protocol-micloud.js#L21

public record LoginInfo(bool IsSuccessful, string Message, string Sid, string? UserId = default, string? DeviceId = default, string? ServiceToken = default, string? SecurityToken = default);

public class Xiaomi
{
}
