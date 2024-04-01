<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class MenuListerController extends Controller
{
    public function getData()
    {
        $url = 'http://localhost:8000/api/menu';         

        $ch = curl_init();
        curl_setopt($ch, CURLOPT_URL, $url);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "GET");
        
        $result = curl_exec($ch);
        $error = curl_error($ch);

        curl_close($ch);

        if ($error) {
            return response()->json(['error' => $error], 500);
        }

        // Parse the JSON response
        $data = json_decode($result, true);


        return response()->json($data);
    }
}



