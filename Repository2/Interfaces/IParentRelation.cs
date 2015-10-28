namespace MilFormat.Interfaces
{
    public interface IParentRelation<out TParent>
    {
        TParent GetParent();
    }
}