<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class MenuListerController extends Controller
{
    //TODO: why is the timeout??
    public function getData()
    {
        /*
        $url = '/api/menu';
        $ch = curl_init();
        curl_setopt($ch, CURLOPT_URL, $url);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "GET");

        $result = curl_exec($ch);
        $error = curl_error($ch);

        curl_close($ch);
        error_log("itt vagyok");
        error_log("result:" + $result);



        if ($error) {
            return response()->json(['error' => $error], 500);
        } else {
            $menuItems = response()->json();
            return view('menu', ['menuItems' => $menuItems]);
            
        }
}       */
    
        // Your logic to generate JSON data
        $data = [
            'name' => 'Pizza',
            'description' => 'Pizza ala mezon',
            'price' => '12',            
        ];

        $menuItems = json_encode($data);
        //return response()->json($data);
        return view('menu', ['menuItems' => $data]);
    }
}



