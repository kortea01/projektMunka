<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreUserRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {

        $rules = [
            'first_name' => 'required|string|max:255',
            'last_name' => 'required|string|max:255',
            'phone' => 'required|string|max:15',
            'address' => 'required|string|max:255',
            'city' => 'required|string|max:255',
            'zip' => 'required|int',
//            'email' => 'required|string|email|max:255|unique:users',
//            'password' => 'required|string|min:8',
        ];

        if (auth()->check() && auth()->user()->role === 'admin') {
            $rules['role'] = 'required|in:customer,manager,admin';
        } else {
            $rules['role'] = 'required|in:customer';
        }

        return $rules;

    }
}
