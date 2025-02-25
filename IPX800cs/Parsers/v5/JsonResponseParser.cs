﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using IPX800cs.Exceptions;

namespace IPX800cs.Parsers.v5;

internal static class JsonResponseParser
{
    public static IOResponse ParseIO(this string jsonResponse)
    {
        return Parse<IOResponse>(jsonResponse);
    }
    
    public static IEnumerable<IOResponse> ParseCollectionIO(this string jsonResponse)
    {
        return ParseCollection<IOResponse>(jsonResponse);
    }
    
    public static AnaResponse ParseAna(this string jsonResponse)
    {
        return Parse<AnaResponse>(jsonResponse);
    }
    
    public static IEnumerable<AnaResponse> ParseCollectionAna(this string jsonResponse)
    {
        return ParseCollection<AnaResponse>(jsonResponse);
    }
    
    public static IEnumerable<TimerResponse> ParseCollectionTimers(this string jsonResponse)
    {
        return ParseCollection<TimerResponse>(jsonResponse);
    }

    private static List<T> ParseCollection<T>(string jsonResponse) where T : class
    {
        return Parse<List<T>>(jsonResponse);
    }

    private static T Parse<T>(string jsonResponse) where T : class
    {
        try
        {
            var parsedResponse = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            
            if (parsedResponse == null)
            {
                throw new IPX800InvalidResponseException(jsonResponse);
            }

            var validationCtx = new ValidationContext(parsedResponse);
            Validator.ValidateObject(parsedResponse, validationCtx);

            return parsedResponse;
        }
        catch (Exception e) when (e is not IPX800InvalidResponseException)
        {
            throw new IPX800InvalidResponseException(jsonResponse, e);
        }
    }
}