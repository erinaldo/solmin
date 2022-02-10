Public Class SerializerWrapper

     readonly JsonSerializer serializer = new JsonSerializer()

    public void Serialize(Stream ms, object obj)
    {
        var jsonTextWriter = new JsonTextWriter(new StreamWriter(ms));
        serializer.Serialize(jsonTextWriter,obj);
        jsonTextWriter.Flush();
        ms.Position = 0;
    }

    public TType Deserialize<TType>(Stream ms)
    {
        var jsonTextReader = new JsonTextReader(new StreamReader(ms));
        return serializer.Deserialize<TType>(jsonTextReader);
    }
End Class
