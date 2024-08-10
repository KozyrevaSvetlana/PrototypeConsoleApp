namespace PrototypeConsoleApp.Models.Interfaces
{
    // 1. Дженерик интерфейс для реализации шаблона "Прототип"
    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
