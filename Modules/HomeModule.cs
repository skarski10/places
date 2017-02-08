using Nancy;
using PlacesVisited.Objects;
using System.Collections.Generic;

namespace PlacesVisited
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/places_visited"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["/places_visited.cshtml", allPlaces];
      };
      Get["/places_visited/new"] = _ => {
        return View["place_form.cshtml"];
      };
      Post["/places_visited"] = _ => {
        Place newPlace = new Place(Request.Form["new-city"]);
        List<Place> allPlaces = Place.GetAll();
        return View["places_visited.cshtml", allPlaces];
      };
      Get["/places_visited/{id}"] = parameters => {
        Place city = Place.Find(parameters.id);
        return View["/place.cshtml", city];
      };
    }
  }
}
