namespace TrialOfFortune.Classes
{
    public interface ISerializable<T> where T : new()
    {
        string Serialize();
        T Deserialize(string itemObjectSerialized);
    }
}
