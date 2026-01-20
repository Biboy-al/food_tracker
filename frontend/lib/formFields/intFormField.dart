import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class IntFormField extends StatelessWidget {

  final String label;
  final String  hintText;
  final FormFieldValidator<String> validator;
  final FormFieldSetter<String> onSaved;

  const IntFormField({
    super.key,
    required this.label,
    required this.validator,
    required this.onSaved,
    this.hintText = "",

    });

  @override
  Widget build(BuildContext context) {
    
    return TextFormField(
      decoration: InputDecoration(
        labelText: label,
        hintText: hintText

      ),

      inputFormatters: <TextInputFormatter>[
              FilteringTextInputFormatter.allow(RegExp(r'^\d+\.?\d{0,1}'))
            ],

      validator: validator,

      onSaved: onSaved,
    );
  }

}