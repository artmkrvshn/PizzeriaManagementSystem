using System;

namespace DesktopApplication.Model;

public class Card<T> : BaseModel
{
    private T _product;

    private string _description;

    private string _image;

    private Uri _imageUri;

    #region Properties 

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

    public string Image
    {
        get => _image;
        set => SetField(ref _image, value);
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
        _image = image;
        _imageUri = new Uri($"pack://application:,,,/DesktopApplication;component/Images/{image}", UriKind.Absolute);
    }
}