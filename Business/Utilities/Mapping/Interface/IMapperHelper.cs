namespace Business.Utilities.Mapping.Interface
{
    public interface IMapperHelper
    {
        // Kaynak nesneyi hedef türüne dönüştürür
        TDestination Map<TDestination>(object? source);

        // Var olan nesneleri haritalar
        void Map(object? source, object? destination);

        // Liste haritalama
        IList<TDestination> MapList<TSource, TDestination>(IList<TSource> source);
    }
}
