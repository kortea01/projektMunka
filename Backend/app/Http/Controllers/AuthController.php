<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreUserRequest;
use App\Models\User;
use Illuminate\Http\Request;
use App\Http\Controllers\Controller;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;

class AuthController extends Controller
{
    public function register( StoreUserRequest $request){
        
        $user = User::create([
            "first_name" => $request->first_name,
            "last_name" => $request->last_name,
            "role" => 'customer', // when registering you always become customer
            "phone" => $request->phone,
            "address" => $request->address,
            "zip" => $request->zip,
            "city" => $request->city,
            "email" => $request->email,
            "password" => Hash::make($request->password),
        ]);

        return response()->json([
            'message' => 'User created successfully!',
        ], 200);
    }


    public function login(Request $request)
    {
        $user = User::where("email", $request->email)->first();
        
        if (!$user) {
            return response()->json(["message" => "User not valid"], 401);
        }

        if (!Hash::check($request->password, $user->password)) {
            return response()->json(["message" => "Incorrect password"], 401);
        }

        $role = $user->role;
        $token = $user->createToken('AuthToken', [$role])->plainTextToken;
        
        return response()->json([
            'message' => 'Succesfull login!',
            'token' => $token,
            'Type' => 'Bearer',
            'role' => $user->role, // include user role in response
            'id' => $user->id // include user id in response
        ], 200);
    }

    public function logout() {
        $user = Auth::user();
        if ($user) {
            $user->currentAccessToken()->delete();
            return response()->json(['message' => 'OK'], 200);
        } else {
            return response()->json(['message' => 'No active user session'], 401);
        }
        
    }

    public function logoutEverywhere() {
        $user = Auth::user();
        if ($user) {
            $user->tokens()->delete();
            return response()->json(['message' => 'OK'], 200);
        } else {
            return response()->json(['message' => 'No active user session'], 401);
        }

    }

}
