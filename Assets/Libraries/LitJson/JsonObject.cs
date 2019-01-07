/**
 * @file    JsonObject.cs
 * @class   JsonObject
 * @description
 *          JSON 문자열을 파싱하여 생성되는 오브젝트의 인터페이스.
 *          JSON을 통해 생성되는 오브젝트는 본 클래스를 상속받아 사용한다.
 */

#pragma warning disable 0436

using LitJson;

public abstract class JsonObject
{
    public const string Empty = "{}";

    /**
     * @brief   JSON문자열을 파싱하여 객체를 생성한다.
     * @param   json    JSON문자열.
     * @return  생성된 JsonObject 객체.
     * @usage
     *      JsonObjectChild obj = JsonObject.Parse<JsonObjectChild>(json);
     */
    public static T Parse<T>(string json) where T : JsonObject
    {
        return JsonMapper.ToObject<T>(json);
    }

    /**
     * 객체의 JSON문자열을 얻는다.
     */
    public string ToJson()
    {
        return JsonMapper.ToJson(this);
    }
}
