namespace TULU;

public static class URLs
{
    public static string baseUrl = "https://fapi.binance.com";
    public static string balance = "/fapi/v2/balance";
    public static string ping = "/fapi/v1/ping";
    public static string checkServerTime = "/fapi/v1/time";
    public static string kline = "/fapi/v1/klines";
    public static string continuousKlines = "/fapi/v1/continuousKlines";
    public static string price = "/fapi/v1/ticker/price";
    public static string order = "/fapi/v1/order";
    public static string accountInformation = "/fapi/v2/account";
    public static string exchangeInfo = "fapi/v1/exchangeInfo";
    public static string keepaliveUserDataStream = "/fapi/v1/listenKey";
    public static string streamBaseUrl1 = "wss://fstream.binance.com/ws/";
    public static string streamBaseUrl2 = "wss://fstream-auth.binance.com/ws/";
    public static string streamListenKeyUrl = "/fapi/v1/listenKey";
}