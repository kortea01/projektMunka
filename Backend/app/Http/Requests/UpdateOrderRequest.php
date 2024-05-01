<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class UpdateOrderRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return false;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        return [
            //
            'user_id' => 'required|exists:users,id',
            'order' => 'required|array',
            'total' => 'required|numeric',
            'status' => 'required|string',
            'payment_method' => 'required|string',
            'delivery_address' => 'required|string',
            'delivery_note' => 'nullable|string'
        ];
    }
}
