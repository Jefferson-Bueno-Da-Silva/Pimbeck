import React from 'react'
import { Image, View } from 'react-native'
import { shadow } from '../../styles/shadow'

import { styles } from './styles'

export const sizeTypeProp = {
  small: 48,
  medium: 58,
}

/**
 * Retorna o Avatar
 * @param {'small' | 'medium'} sizeType
 * @returns
 */
const Avatar = ({ sizeType, profile }) => {
  return (
    <View style={styles.container}>
      <View style={{...shadow.shadow8, backgroundColor: 'transparent', borderRadius: 20}}>
        <Image
          source={{uri: profile}}
          style={[
            styles.profile,
            { height: sizeTypeProp[sizeType], width: sizeTypeProp[sizeType] },
          ]}
        />
      </View>
    </View>
  )
}

export default Avatar
