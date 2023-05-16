using System;

namespace DesktopApplication.Model;

public class Card<T> : BaseModel
{
    private T _product;
    private string _description;
    private Uri _imageUri;

    #region Переназови 

    public T Product
    {
        get => _product;
        set => SetField(ref _product, value);
    }

    public string Description
    {
        get => _description;
        set => SetField(ref _description, value);
    }

    public Uri ImageUri
    {
        get => _imageUri;
        set => SetField(ref _imageUri, value);
    }

    #endregion

    public Card(T product, string description, string image)
    {
        _product = product;
        _description = description;
        _imageUri = new Uri($"pack://application:,,,/DesktopApplication;component/Images/{image}", UriKind.Absolute);
    }
}