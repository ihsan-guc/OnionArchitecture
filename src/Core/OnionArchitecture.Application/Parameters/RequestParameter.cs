﻿namespace OnionArchitecture.Application.Parameters
{
    public class RequestParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public RequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public RequestParameter()
        {
            PageNumber = 1;
            PageSize = 10;
        }
    }
}
