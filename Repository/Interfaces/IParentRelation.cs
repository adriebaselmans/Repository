namespace Repository.Interfaces
{
    public interface IParentRelation<out TParent>
    {
        TParent GetParent();
    }
}