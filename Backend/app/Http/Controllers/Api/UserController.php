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
            return User::paginate(50);
        } else { // others will get their own data
            return response()->json($user, 200);
            //return response()->json(["message" => "Unauthorized"], 401);
        }
    }
    public function listAll()
    {
        $user = Auth::user();
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {  // intelephense false positive?
            return User::all();
        } else { // others will get their own data
            return response()->json($user, 200);
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

    public function show(User $user, $id)
    {
        $user = Auth::user();
        // admins and managers will see all users
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {  // intelephense false positive?
            return User::findOrFail($id);
        } else { // others will get their own data
            return response()->json($user);
            //return response()->json(["message" => "Unauthorized"], 401);
        }
    }

    public function update(StoreUserRequest $request, $id)
    {
        $user = Auth::user(); 
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            $target = User::findOrFail($id);
            $target->update($request->all());
            return response()->json(["message" => "User Successfully updated.", $target], 201);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
        //return response()->json("dafuq");
    }

    public function destroy(User $user)
    {
        $user->delete();

        return response()->json(null, 204);
    }
}
