using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMobileApp.ViewViewModels.AppImages.URIContents;

public class URIViewModel : BaseViewModel
{
    private ImageSource _getImageSource;
    private TitleURI _model;

    public URIViewModel(TitleURI model)
    {
        _model = model;
        //Title = UriImageSource.TitleURI;

    }

    public ImageSource GetImageSource
    {
        get
        {
            if (_getImageSource == null)
            {
                _getImageSource = GetImage(_model.DJImageURL);
            }
            return _getImageSource;
        }
    }

    private ImageSource GetImage(string url)
    {
        var imgsrc = new UriImageSource { Uri = new Uri(url) };
        //var imgsrc = new UriImageSource { Uri = new Uri(DJImageURL), Title = "My Image Title" };
        imgsrc.CachingEnabled = false;
        imgsrc.CacheValidity = TimeSpan.FromHours(1);

        return imgsrc;
    }

}
