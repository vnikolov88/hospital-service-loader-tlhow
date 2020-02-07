namespace HospitalService.Loader.TLHOW.Extensions
{
    public static class TLHOWDepartment
    {
        public static string GetDescriptionHtml(this Models.TLHOWDepartment s)
        {
            var descHtml = string.Empty;
            if(!string.IsNullOrWhiteSpace(s.DescriptionHeadline))
                descHtml += $"<h1>{s.DescriptionHeadline}</h1><br/>";

            if (!string.IsNullOrWhiteSpace(s.DescriptionHtml))
                descHtml += $"{s.DescriptionHtml}<br/>";

            if (!string.IsNullOrWhiteSpace(s.Description2Headline))
                descHtml += $"<h1>{s.Description2Headline}</h1><br/>";

            if (!string.IsNullOrWhiteSpace(s.Description2Html))
                descHtml += $"{s.Description2Html}<br/>";

            if (!string.IsNullOrWhiteSpace(s.Description3Headline))
                descHtml += $"<h1>{s.Description3Headline}</h1><br/>";

            if (!string.IsNullOrWhiteSpace(s.Description3Html))
                descHtml += $"{s.Description3Html}<br/>";

            if (!string.IsNullOrWhiteSpace(s.Description4Headline))
                descHtml += $"<h1>{s.Description4Headline}</h1><br/>";

            descHtml += $"{s.Description4Html}";
            return descHtml;
        }
    }
}
