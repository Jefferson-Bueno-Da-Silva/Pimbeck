import React, { useState } from "react";
import { View, Image, Text } from "react-native";

// components
import Avatar from "../Avatar";
import Input from "../Input";

// Styles
import { styles } from "./styles";
import { fonts } from "../../styles/fonts";

// Assets
import { logo } from "../../assets";

const Header = ({ value, setValue, onPressSearch }) => {
  return (
    <View style={styles.container}>
      <View style={styles.top}>
        <Image source={logo} style={styles.logo} resizeMode="contain" />
      </View>
      <View style={styles.middle}>
        <Text style={[fonts.captionBold]}>Um lugar lindo para viver.</Text>
        <Text style={[fonts.captionRegular]}>
          Procure o lugar que você deseja passar seu tempo
        </Text>
      </View>
      <View style={styles.bottom}>
        <Input value={value} setValue={setValue} onPress={onPressSearch} />
      </View>
    </View>
  );
};

export default Header;
