namespace Set
{
    interface IObjSet<T>
    {
        T Extraction();
        void MoveNext();
        void ToFirst();
        bool IsEnd();
    }
}
