public class Catalog<T> where T : Book
{
    private List<T> _items = new List<T>();
    private HashSet<string> _isbnSet = new HashSet<string>();
    private SortedDictionary<string, List<T>> _genreIndex = new SortedDictionary<string, List<T>>();

    public bool AddItem(T item)
    {
        if (_isbnSet.Contains(item.ISBN))
        {
            return false;
        }
        _isbnSet.Add(item.ISBN);
        _items.Add(item);
        if (!_genreIndex.ContainsKey(item.Genre))
        {
            _genreIndex[item.Genre] = new List<T>();
        }

        // Add book to its genre list
        _genreIndex[item.Genre].Add(item);
        return true;
    }

    public List<T> this[string genre]
    {
        get
        {
            if (_genreIndex.ContainsKey(genre))
                return _genreIndex[genre];

            return new List<T>();
        }
    }

    public IEnumerable<T> FindBooks(Func<T,bool> predicate)
    {
        return _items.Where(predicate);
    }


}