public class InputCatch
{
    [DllImport("User32.dll")]
    public static extern short GetAsyncKeyState(Keys vKey);
}
