<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreOrderRequest;
use App\Http\Requests\UpdateOrderRequest;
use App\Models\Order;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use App\Models\Dish;

class OrderController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        // # protected endpoint 
        // # list all orders of current user or all orders if current user is admin/manager
        $user = Auth::user();
        if ($user->tokenCan('admin') || $user->tokenCan('manager')) {
            return Order::orderBy('created_at')->paginate(50);
        } else {
            return Order::where('user_id', $user->id)->orderBy('created_at')->paginate(50);
            // $object['items'] = json_decode($object['items']);
            //return $object;
        }
    }
    public function listAll ()
    {
        // no auth endpoint 
        return Order::orderBy('created_at')->get()->toJson();
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create(StoreOrderRequest $request)
    {
        //
        $user = Auth::user();
        if (Auth::check() && $user->tokenCan('customer')) {
            
            $address = implode(' ', [ $user->zip, $user->city, $user->address ]);
            $total = 0;
            foreach ($request->items as $item) {
                $dish = Dish::find($item['id']);
                $name = $dish->name;
                $price = $dish->price;
                $total += $price * $item['quantity'];
                $items[] = [
                    'id' => $item['id'],
                    'name' => $name,
                    'quantity' => $item['quantity'],
                    'price' => $price,
                    'total_price' => $price * $item['quantity']
                ];
            }
            $order = Order::Create([
                'user_id' => $user->id,     // aki kuldi a requestet
                'order' => json_encode($items),// hogy lesz ertelmesen dekodolva?
                'total' => $total,          // ezen az oldalon szamolt ertek nem requestbol jon 
                'status' => 'pending', // pending, confirmed, delivered, canceled
                'payment_method' => $request->payment_method, // ez a requestbol jonne vagy a user objectbol?
                'delivery_address' => $address,               // ezt a user objectbol szereljuk ossze
                'delivery_note' => $request->delivery_note,   // ez a requestbol jon
            ]);
            
            $order->save();

            return response()->json(["message" => "Order Successfully created.",$order], 200);
        } else {
            return response()->json(["message" => "Unauthorized"], 401);
        }
    }
 
    /**
     * Display the specified resource.
     */
    public function show(Order $order)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Order $order)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateOrderRequest $request, Order $order)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Order $order)
    {
        //
    }
}
