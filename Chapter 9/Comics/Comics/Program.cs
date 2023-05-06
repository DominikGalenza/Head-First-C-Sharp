using Comics;

IEnumerable<string> mostExpensive = 
	from comic in Comic.Catalog
	where Comic.Prices[comic.Issue] > 500
	orderby Comic.Prices[comic.Issue] descending
	select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";