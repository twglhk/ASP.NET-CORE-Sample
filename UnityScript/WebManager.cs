using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class GameResult
{
    public string UserName;
    public int Score;
}

public class WebManager : MonoBehaviour
{
    string _baseUrl = "https://localhost:44375/api";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");

        GameResult res = new GameResult()
        {
            UserName = "BABAYAGA",
            Score = 10000
        };

        SendPostRequest("ranking", res, (uwr) =>
        {
            Debug.Log("TODO : UI update");
        });

        SendGetAllRequest("ranking", (uwr) =>
        {
            Debug.Log("TODO : UI update");
        });
    }

    public void SendPostRequest(string url, object obj, Action<UnityWebRequest> callback)
    {
        StartCoroutine(CoSendWebRequest(url, "POST", obj, callback));
    }

    public void SendGetAllRequest(string url, Action<UnityWebRequest> callback)
    {
        StartCoroutine(CoSendWebRequest(url, "GET", null, callback));
    }

    IEnumerator CoSendWebRequest(string url, string method, object obj, Action<UnityWebRequest> callback)
    {
        yield return null;

        string sendUrl = $"{_baseUrl}/{url}/";

        byte[] jsonBytes = null;

        if (obj != null)
        {
            string jsonStr = JsonUtility.ToJson(obj);
            jsonBytes = Encoding.UTF8.GetBytes(jsonStr);
        }

        var uwr = new UnityWebRequest(sendUrl, method);
        uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
        uwr.downloadHandler = new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");

        Debug.Log($"SEND START");

        yield return uwr.SendWebRequest();

        Debug.Log($"SEND END");

        if (uwr.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(uwr.error);
        }
        else
        {
            Debug.Log("Recv " + uwr.downloadHandler.text);
            callback.Invoke(uwr);
        }
    }
}
