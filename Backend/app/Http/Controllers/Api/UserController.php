<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Models\User;
#use Illuminate\Http\Request;
use App\Http\Requests\StoreUserRequest;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;

class UserController extends Controller
{
    public function index()
    {
        $user = Auth::user();
        // admins and managers will see all users
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {  // intelephense false positive?
            return User::all();
        } else { // others will get their own data
            return response()->json($user);
            //return response()->json(["message" => "Unauthorized"], 401);
        }
    }

    public function store(StoreUserRequest $request)
    {
        /*$user = User::create($request->validated());
        $user->password = Hash::make($request->password);
        return response()->json($user, 201);*/
        $user = User::create([
            "name" => $request->name,
            "email" => $request->email,
            #add the other fields
            "password" => Hash::make($request->password),
        ]);
        return response()->json($user, 201);
    }

    public function show(User $user)
    {
        return response()->json($user);
    }

    public function update(StoreUserRequest $request, User $user)
    {
        $user->update($request->all());

        return response()->json($user);
    }

    public function destroy(User $user)
    {
        $user->delete();

        return response()->json(null, 204);
    }
}
